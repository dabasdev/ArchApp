using System.Collections;
using System.Diagnostics;
using static System.IO.Path;

namespace ArchApp;

public sealed class FileService
{
    public static byte[] DatabaseFileInsert(string varFilePath)
    {
        using var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read);
        using var reader = new BinaryReader(stream);
        var file = reader.ReadBytes((int)stream.Length);

        reader.Close();

        return file;
    }

    public static string DatabaseFileRead(string fileName, byte[]? file)
    {
        var byteArray = file?.ToArray();

        var filename = $"{GetTempFileName()}{fileName}";

            using var fileStream = new FileStream(filename, FileMode.Create,
                FileAccess.ReadWrite /*,  FileShare.ReadWrite , 4096 , FileOptions.DeleteOnClose */);
            // Open file for reading

            // Writes a block of bytes
            fileStream.Write(byteArray!, 0, byteArray!.Length);

            var prc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = filename,
                    UseShellExecute = true
                }
            };
            prc.Start();

            //// Close file stream
            fileStream.Close();
            fileStream.Dispose();

        return filename;
    }
}