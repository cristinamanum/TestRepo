call "%VS140COMNTOOLS%VsDevCmd.bat"
msbuild /flp1:logfile=binaries\msbuild.log "Proj1.sln"
