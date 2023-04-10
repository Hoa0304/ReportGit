# Git for Programmers
__10/04__/2023
## Chapter 12
### Fixing Mistakes



<details>
<summary>Amend the last commit</summary>

- Add changes to the previous commit
- Edit the commit message and add any additional changes.
```
$git commit --amend
```

- If you don't want to edit the message when you add the files, enter:

```
$git --amend --no-edit
```

</details>

<details>
<summary>Undo a commit</summary>

- Creates a new commit that undoes the changes made in a previous commit.

```
$git revert
```

</details>


<details>
<summary>Reset to a previous commit</summary>

- Go back to a previous commit and discard any changes made since then

```
$git reset
```
- This will remove any commits made after the specified commit and reset the branch to that commit.

</details>


<summary>Branch name change</summary>


```
$git branch -m <currentName> <desiredName>
```

</details>