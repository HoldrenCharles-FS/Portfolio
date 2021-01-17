# Git: Feature Branch Workflow

## What is Feature Branch Workflow?
Feature Branch Workflow is the formal process of submitting changes to a project in distributed version control environment. In Git, this is done by  creating branches and pull requests that can be reviewed by other potential developers before overwriting (known as merging) to the master branch of the project.

## Commands
**Basics**

| Command        | Description     |
| :------------- | :----------- |
|  git checkout -b [Feature\_Branch_Name] | Creates a new branch within the local repository    |
| git checkout [Feature\_Branch_Name]   |  Changes branch to an already existing one |
| git push -set--upstream origin [Feature\_Branch\_Name]   |  Pushes feature branch to central repository. After the branch has been pushed to central repository, *git push* can be used without additional parameters.|

**Branch Commands**

| Command        | Description     |
| :------------- | :----------- |
|  git branch | View a list of existing branches.   |
|  git branch --show-current | Shows the current branch name    |
|  git branch --create-reflog | Creates the branch's reflog    |
|  git branch --edit-description | Edit description of the branch    |

## Reference Links
**What is Feature Branch Workflow?**

* [Git Feature Branch Workflow | Atlassian.com](https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow)

**Commands**

* [git-branch Documentation | Git](https://git-scm.com/docs/git-branch)
