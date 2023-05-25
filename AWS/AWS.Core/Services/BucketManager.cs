using AWS.Core.Interfaces; 

namespace AWS.Core.Services
{
    public class BucketManager : IBucketManager
    {
        public string GetFiles()
        {
            return "Files";
        }
    }
}
