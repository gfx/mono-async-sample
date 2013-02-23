using System;
using System.IO;
using System.Threading.Tasks;

class C {
    public static void Main(string[] args) {
        var source      = args[0];
        var destination = args[1];

        Task.Run( async () => {
            using (FileStream sourceStream = File.Open(source, FileMode.Open))
            using (FileStream destinationStream = File.Create(destination))
            {
                await sourceStream.CopyToAsync(destinationStream);
            }
        }).Wait();
    }
}
