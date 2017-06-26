#r "tools/UpdateCSProjVersion.dll"
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Debug");
 
//////////////////////////////////////////////////////////////////////
///    Build Variables
/////////////////////////////////////////////////////////////////////
// The output directory the build artefacts saved too
//////////////////////////////////////////////////////////////////////
var outputDir = Directory("./mvMVC/bin") + Directory(configuration);  
var slnFile = "./myMVC.sln";
var projFile = "./myMVC/myMVC.csproj";
var buildSettings = new DotNetCoreBuildSettings
     {
         Framework = "netcoreapp1.1",
         Configuration = configuration,
         OutputDirectory = outputDir
     };
//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////
Task("Clean")
  .Does( () => {
    Information("OutDirectory: {0}", outputDir);
    if (DirectoryExists(outputDir))
    {
        DeleteDirectory(outputDir, recursive:true);
    }
  });

Task("AppendBuildVersion")
  .IsDependentOn("Clean")
  .Does( () => {
      Information("Changing Assembly Version of myMVC: {0}", projFile);
      UpdateBuildNumber(projFile, "15");
  });

Task("Restore")
  .IsDependentOn("AppendBuildVersion")
  .Does(() => {
        DotNetCoreRestore();
  });

Task("Build")
  .IsDependentOn("Restore")
  .Does(() => {
        DotNetCoreBuild(slnFile);
  });

  Task("Run Tests")
    .IsDependentOn("Build")
    .Does( () => {

    });

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Run Tests");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);