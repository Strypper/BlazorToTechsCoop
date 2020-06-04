using System.Threading.Tasks;
using BlazorInputFile;

namespace ToTechsDotNet.Services{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}