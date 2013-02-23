// requires Mono C# compiler version 3.0
using System;
using System.IO;
using System.Threading.Tasks;

class C {
    public static void Main(string[] args) {
        var source      = args[0];
        var destination = args[1];

        Task.Run( async () => {
            await FileCopyAsync(source, destination);
        }).Wait();
    }

    private async static Task FileCopyAsync(string source, string destination) {
        using (var sourceStream      = File.Open(source, FileMode.Open))
        using (var destinationStream = File.Create(destination))
        {
            await sourceStream.CopyToAsync(destinationStream);
        }
    }
}
