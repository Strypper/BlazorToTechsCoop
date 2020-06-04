using System.IO;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;

namespace ToTechsDotNet.Services{
    public class UploadFileService : IFileUpload{
        private readonly IWebHostEnvironment _env;
        public UploadFileService(IWebHostEnvironment env){
            this._env = env;
        }
        public async Task UploadAsync(IFileListEntry fileEntry){
            var path = Path.Combine(_env.WebRootPath, "Upload", fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using(FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write)){
                ms.WriteTo(file);
            }
        }
    }
}