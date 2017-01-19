@rem Generate the C# code for .proto files

@setlocal

@rem enter this directory
@cd /d %~dp0

@set TOOLS_PATH=..\packages\Grpc.Tools.1.0.1\tools\windows_x86

%TOOLS_PATH%\protoc.exe ^
 -I./ ^
 --csharp_out . ./GRPCIntService.proto ^
 --grpc_out . ^
 --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe 

@endlocal