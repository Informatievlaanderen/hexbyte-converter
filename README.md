# Be.Vlaanderen.Basisregisters.Utilities.HexByteConverter [![Build Status](https://github.com/Informatievlaanderen/hexbyte-converter/workflows/Build/badge.svg)](https://github.com/Informatievlaanderen/hexbyte-converter/actions)

## Goal

Easily convert between byte array and hex strings.

## Usage

### Converting from byte array to hex string

```csharp
namespace Example
{
    using System;
    using Be.Vlaanderen.Basisregisters.Utilities.HexByteConvertor;

    public class Test
    {
        public byte[] Bytes { get; set; }

        public override string ToString()
            => Bytes.ToHexString();
    }

    public class Program
    {
        public static void Main(string[] _)
        {
            var test = new Test { Bytes = new [] { (byte)0b0000_0101, (byte)0b1110_0101, (byte)0b0000_0001 } };
            Console.WriteLine(test);
        }
    }
}
```

Running this will result in:

```bash
$ dotnet run
05E501
```

### Converting from hex string to byte array

```csharp
namespace Example
{
    using System;
    using Be.Vlaanderen.Basisregisters.Utilities.HexByteConvertor;

    public class Test
    {
        public string HexString { get; set; }

        public byte[] ToByteArray()
            => HexString.ToByteArray();
    }

    public class Program
    {
        public static void Main(string[] _)
        {
            var test = new Test { HexString = "0F1337FF" };
            var b = test.ToByteArray();
            Console.WriteLine("{0} {1} {2} {3}", b[0], b[1], b[2], b[3]);
        }
    }
}
```

Running this will result in:

```bash
$ dotnet run
15 19 55 255
```

## License

[MIT License](https://choosealicense.com/licenses/mit/)

## Credits

### Languages & Frameworks

* [.NET Core](https://github.com/Microsoft/dotnet/blob/master/LICENSE) - [MIT](https://choosealicense.com/licenses/mit/)
* [.NET Core Runtime](https://github.com/dotnet/coreclr/blob/master/LICENSE.TXT) - _CoreCLR is the runtime for .NET Core. It includes the garbage collector, JIT compiler, primitive data types and low-level classes._ - [MIT](https://choosealicense.com/licenses/mit/)
* [.NET Core APIs](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT) - _CoreFX is the foundational class libraries for .NET Core. It includes types for collections, file systems, console, JSON, XML, async and many others._ - [MIT](https://choosealicense.com/licenses/mit/)
* [.NET Core SDK](https://github.com/dotnet/sdk/blob/master/LICENSE.TXT) - _Core functionality needed to create .NET Core projects, that is shared between Visual Studio and CLI._ - [MIT](https://choosealicense.com/licenses/mit/)
* [Roslyn and C#](https://github.com/dotnet/roslyn/blob/master/License.txt) - _The Roslyn .NET compiler provides C# and Visual Basic languages with rich code analysis APIs._ - [Apache License 2.0](https://choosealicense.com/licenses/apache-2.0/)
* [F#](https://github.com/fsharp/fsharp/blob/master/LICENSE) - _The F# Compiler, Core Library & Tools_ - [MIT](https://choosealicense.com/licenses/mit/)
* [F# and .NET Core](https://github.com/dotnet/netcorecli-fsc/blob/master/LICENSE) - _F# and .NET Core SDK working together._ - [MIT](https://choosealicense.com/licenses/mit/)

### Libraries

* [Paket](https://fsprojects.github.io/Paket/license.html) - _A dependency manager for .NET with support for NuGet packages and Git repositories._ - [MIT](https://choosealicense.com/licenses/mit/)
* [FAKE](https://github.com/fsharp/FAKE/blob/release/next/License.txt) - _"FAKE - F# Make" is a cross platform build automation system._ - [MIT](https://choosealicense.com/licenses/mit/)

### Tooling

* [npm](https://github.com/npm/cli/blob/latest/LICENSE) - _A package manager for JavaScript._ - [Artistic License 2.0](https://choosealicense.com/licenses/artistic-2.0/)
* [semantic-release](https://github.com/semantic-release/semantic-release/blob/master/LICENSE) - _Fully automated version management and package publishing._ - [MIT](https://choosealicense.com/licenses/mit/)
* [semantic-release/changelog](https://github.com/semantic-release/changelog/blob/master/LICENSE) - _Semantic-release plugin to create or update a changelog file._ - [MIT](https://choosealicense.com/licenses/mit/)
* [semantic-release/commit-analyzer](https://github.com/semantic-release/commit-analyzer/blob/master/LICENSE) - _Semantic-release plugin to analyze commits with conventional-changelog._ - [MIT](https://choosealicense.com/licenses/mit/)
* [semantic-release/exec](https://github.com/semantic-release/exec/blob/master/LICENSE) - _Semantic-release plugin to execute custom shell commands._ - [MIT](https://choosealicense.com/licenses/mit/)
* [semantic-release/git](https://github.com/semantic-release/git/blob/master/LICENSE) - _Semantic-release plugin to commit release assets to the project's git repository._ - [MIT](https://choosealicense.com/licenses/mit/)
* [semantic-release/github](https://github.com/semantic-release/github/blob/master/LICENSE) - _Semantic-release plugin to publish a GitHub release._ - [MIT](https://choosealicense.com/licenses/mit/)
* [semantic-release/npm](https://github.com/semantic-release/npm/blob/master/LICENSE) - _Semantic-release plugin to publish a npm package._ - [MIT](https://choosealicense.com/licenses/mit/)
* [semantic-release/release-notes-generator](https://github.com/semantic-release/release-notes-generator/blob/master/LICENSE) - _Semantic-release plugin to generate changelog content with conventional-changelog._ - [MIT](https://choosealicense.com/licenses/mit/)
* [commitlint](https://github.com/conventional-changelog/commitlint/blob/master/license.md) - _Lint commit messages._ - [MIT](https://choosealicense.com/licenses/mit/)
* [commitizen/cz-cli](https://github.com/commitizen/cz-cli/blob/master/LICENSE) - _The commitizen command line utility._ - [MIT](https://choosealicense.com/licenses/mit/)
* [commitizen/cz-conventional-changelog](https://github.com/commitizen/cz-conventional-changelog/blob/master/LICENSE) _A commitizen adapter for the angular preset of conventional-changelog._ - [MIT](https://choosealicense.com/licenses/mit/)
* [husky](https://github.com/typicode/husky/blob/master/LICENSE) - _Git hooks made easy._  - [MIT](https://choosealicense.com/licenses/mit/)

### Flemish Government Libraries

* [Be.Vlaanderen.Basisregisters.Build.Pipeline](https://github.com/informatievlaanderen/build-pipeline/blob/main/LICENSE) - _Contains generic files for all Basisregisters Vlaanderen pipelines._ - [MIT](https://choosealicense.com/licenses/mit/)
