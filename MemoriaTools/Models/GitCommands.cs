using System;
using System.Diagnostics;
using System.IO;

namespace MemoriaTools.Models
{
    public class GitCommands
    {
        // Helper method to run git commands
        private string RunGitCommand(string command, string workingDirectory)
        {
            try
            {
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe", 
                    Arguments = $"/c cd \"{workingDirectory}\" && {command}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(processStartInfo))
                {
                    if (process == null)
                    {
                        return "Failed to start Git process.";
                    }

                    var output = process.StandardOutput.ReadToEnd();
                    var error = process.StandardError.ReadToEnd();
                    
                    var fullOutput = output + "\n" + error;

                    if (fullOutput.Contains("fatal") || fullOutput.Contains("error"))
                    {
                        return $"Error: {fullOutput}";
                    }

                    return fullOutput;
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }

        public string TestRepository(string repoName)
        {
            var repoUrl = $"https://github.com/arthaqs/{repoName}.git";  
            var gitCommand = $"git ls-remote {repoUrl}";

            return RunGitCommand(gitCommand, Directory.GetCurrentDirectory());
        }

        public string Pull(string localRepositoryFolderPath, out string message, string remoteName = "origin", string branchName = "main")
        {
            message = "";
            var gitCommand = $"git pull {remoteName} {branchName}"; 

            var result = RunGitCommand(gitCommand, localRepositoryFolderPath);
            if (result.Contains("fatal") || result.Contains("error"))
            {
                return result;
            }
            else
            {
                message = result.Replace("From ", "").Trim();  
                return "Successfully pulled changes from the repository.";
            }
        }

        public string Commit(string localRepositoryFolderPath, string commitMessage)
        {
            if (string.IsNullOrWhiteSpace(commitMessage))
            {
                return "Commit message cannot be empty.";
            }

            var gitCommand = $"git commit -am \"{commitMessage}\""; 
            return RunGitCommand(gitCommand, localRepositoryFolderPath);
        }

        public string Push(string localRepositoryFolderPath, string remoteName = "origin", string branchName = "main")
        {
            var gitCommand = $"git push {remoteName} {branchName}";
            return RunGitCommand(gitCommand, localRepositoryFolderPath);
        }
    }
}
