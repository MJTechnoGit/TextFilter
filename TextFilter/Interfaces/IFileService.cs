using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TextFilter.Interfaces
{
    public interface IFileService
    {
        string ReadFile(string FileName);
    }
}
