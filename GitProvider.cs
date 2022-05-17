using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;

namespace Sales
{
    /// <summary>
    /// Class for managing version control and data syncronization
    /// </summary>
    static class GitProvider
    {
        static string modelsRepoPath = "some path";
        static void PullModels() // TODO: implement
        {
            using (Repository repo = new Repository(modelsRepoPath))
            {
                //Commands.Pull(repo, );
            }
        }
    }
}
