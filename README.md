# GitHub Terminal Help

## 1. Clone the Repository

Open your terminal, then run:
```bash
git clone https://github.com/michelle-johanson/IS413_Mission4.git
cd IS413_Mission4
```
You should now be inside the project folder.


## Getting started

```bash
git checkout main # Open main branch
git pull origin main # Update main branch locally

git checkout -b yourbranch # Create a new branch for yourself
```

## Make your edits
```bash
git add .
git status # View your edits

git commit -m "Describe your change"

git push origin yourbranch
```

## Open a Pull Request

Go to the GitHub repo in your browser

Click Compare & pull request

Add a short description (optional)

Click Create pull request

Other team members would review and merge it.

## Keep Your Local Copy Updated

Before starting any new work:
```bash
git checkout main
git pull origin main
```
Then create a new branch again for your next task:
```bash
# Check current branch
git branch

# Delete your old branch (optional)
git branch -d yourbranch

# Create a new branch
git checkout -b yourbranch
```

This keeps everyone’s code up-to-date and avoids merge conflicts.