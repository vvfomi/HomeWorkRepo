namespace Module2_HW1;
public class FileService
{
    public void CreateFile(string folderName, string fileName, string text)
    {
        CheckOldestFile(folderName);
        string filePath = folderName + fileName; 
        File.WriteAllText(filePath, text);
    }

    public void CheckOldestFile(string folderName)
    {
        var fileInfos = new DirectoryInfo(folderName).GetFileSystemInfos();

        if (fileInfos.Length < 3)
        {
            return;
        }
        var sortedFileInfos = fileInfos.OrderBy(fileInfo => fileInfo.CreationTime ).ToArray();
        var oldestFile = sortedFileInfos[0];
        oldestFile.Delete();
    }

}
