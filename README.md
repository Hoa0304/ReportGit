# Git for Programmers
__04/04__/2023
## Chapter 11
### Finding a Broken Commit: Bisect and Blame
#### BISECT


<details>
<summary>Start the search process</summary>

```
$git bisect start
```

-  Then, you need to specify the current last bad commit with the command :

```
$git bisect bad
```

- Next, you need to specify a previous commit that you know for sure is working properly with the command :

```
$git bisect good
```

</details>


#### BLAME

1. File history search

- To search for information about the commit you want to find the history of that file.

<details>
<summary>git log</summary>

- This command displays the history of commits and allows you to view information about different commits.


</details>

<details>
<summary>git branch</summary>

- This command displays a list of branches in Git's repository.

</details>

<details>
<summary>git show</summary>

- This command displays information about a specific commit.

</details>


<details>
<summary>git diff</summary>

- This command displays the difference between two commits or between two versions of the same file.


</details>



- Ignore whitespace changes when searching history :

```
$git blame -w
```

- Displays the history of a file and indicates who each line was changed by:

```
$git blame -w -M3
```