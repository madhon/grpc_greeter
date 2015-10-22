@rem Generate the C# code for .proto files

@setlocal

@rem enter this directory
cd /d %~dp0

packages\Google.Protobuf.3.0.0-alpha4\tools\protoc.exe ^
 -I./Greeter/protos ^
 --csharp_out . ^
 --grpc_out . ^
 --plugin=protoc-gen-grpc=packages\Grpc.Tools.0.7.1\tools\grpc_csharp_plugin.exe ./Greeter/protos/helloworld.proto

@endlocal