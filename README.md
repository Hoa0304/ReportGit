# Git for Programmers
__03/04__/2023
## Chapter 10
### Important Git Commands and Metadata
#### STASH


<details>
<summary>What is Stash ?</summary>

- Is a place where you can hold (stash) files you've modified but not yet committed


```
$git push --mirror
```

>  Copy the entire content of a Git repository to another repository, including branches, tags, and commit history.

</details>


<details>
<summary>Command</summary>


```
$git stash 
```

```
$git stash list
```
> show list stash create before

```
$git stash show
```

> Show the changes stored in the stash

</details>


#### CLEAN 

Get rid of it

<details>
<summary>Command</summary>

```
$git clean
```
> Untracked files are gone never to be seen again.


- To actually clean, Git requires that you tell it you really mean it by using the -f (force) flag : 

```
$git clean -f
```

</details>



#### METADATA

<details>
<summary>Using show to see metadata</summary>

```
$git show -s HEAD --format='%an <%ae> %h %d'
```

- git show—the show command.
- -s—silent (or quiet), which suppresses the difference output (try the 
command without it to see).
- HEAD tells show which commit you are interested in.
- %an is the author's name.
- %ae is the author's email address
- %h is the abbreviated commit hash 
- %d information about the current branch's position

</details>