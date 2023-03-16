using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sikreys.Models;


/// <summary>
/// Image - класс представления пути файла в каталоге Files
/// </summary>
public class Image
{
    public int Id { get; set; }

    /// <summary>
    ///  Путь, по которому должен быть найден файл в папке Files
    /// </summary>
    /// <value>Files/{Path}</value>
    public string? Path { get; set; }
}
