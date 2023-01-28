using Cryptor;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\neci0\Downloads\[brokencore.club]_File Protector.zip";
            ByteCryptor byteCryptor = new ByteCryptor("BrokenCore");
            byte[] file = File.ReadAllBytes(filepath);
            byte[] crypted = byteCryptor.Encrypt(file);
            File.WriteAllBytes(filepath, crypted);
        }
    }
}
