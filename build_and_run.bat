cd MathLibrary/MathLibrary
dotnet build -c release

copy bin\Release\MathLibrary.dll ..\..\MathLibraryTest\MathLibraryTest
cd ../../MathLibraryTest/MathLibraryTest

dotnet build
cd bin/Debug
MathLibraryTest.exe