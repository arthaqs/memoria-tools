using MemoriaTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaTools.Controllers
{
    public class GitController
    {
        private GitCommands m_gitCommands;

        public GitController()
        {
            m_gitCommands = new();
        }

        public string TestConnection(string repositoryName)
        {
            return m_gitCommands.TestRepository(repositoryName);
        }

        public string Pull(string localRepositoryFolderPath, out string message)
        {
            var response = m_gitCommands.Pull(localRepositoryFolderPath, out message);

            response = string.Join("\n", response.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));
            message = string.Join("\n", message.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));

            return response;
        }

        public string CommitAndPush(string localRepositoryFolderPath, string commitComment)
        {
            var commitResponse = m_gitCommands.Commit(localRepositoryFolderPath, commitComment);
            var pushResponse = m_gitCommands.Push(localRepositoryFolderPath);

            commitResponse = string.Join("\n", commitResponse.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));
            pushResponse = string.Join("\n", pushResponse.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));

            if (!string.IsNullOrEmpty(commitResponse) && !string.IsNullOrEmpty(pushResponse))
            {
                return commitResponse + "\n" + pushResponse;
            }
            else
            {
                return commitResponse + pushResponse;
            }
        }
    }
}