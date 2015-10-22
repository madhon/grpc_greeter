@rem Generate the C# code for .proto files

@setlocal

@rem enter this directory
cd /d %~dp0

packages\Google.Protobuf\tools\protoc.exe ^
 -I./Greeter/protos ^
 --csharp_out Greeter ^
 --grpc_out Greeter ^
 --plugin=protoc-gen-grpc=packages\Grpc.Tools\tools\grpc_csharp_plugin.exe ./Greeter/protos/helloworld.proto

@endlocal