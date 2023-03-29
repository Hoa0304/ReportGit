# Git for Programmers
__28/03__/2023
## Chapter 7
### Tags 

<details>
<summary>Lightweigh tag</summary>

1. Temporary tag is something that cannot be changed. 
1. It is possible to set a name.
- Lightweight tag is mainly used in temporary local workspaces.
</details>

<details>
<summary>Annotated tag</summary>

1. It is possible to attach the name and email of the person who performed and the date.
1. It is possible to set a name.
1. It is possible to attach a comment.
1. It is possible to attach a signature.
- Annotated tag becomes important when there is a plan to mark important commits. It is usually used to mark commits used for release and can also add annotations alongside.
</details>

#### Use tags





<details>
<summary>Add Lightweigh tag</summary>

<details>
<summary>Add tag</summary>

```
 $ git tag < tagname >
```

</details>

<details>
<summary>Tag command without parameters</summary>

- Show tag list

```
 $ git tag 
```
</details>


<details>
<summary>Show history  </summary>

``` 
$ git log --decorate
```

</details>

</details>

<details>
<summary>Add Annotated tag</summary>

<details>
<summary>Add tag</summary>

```
 $ git tag -a < tagname >
```

</details>

<details>
<summary>Just created a tag and added a comment</summary>

``` 
$ git tag -am "commit" < tagname >
```

</details>


<details>
<summary>Displays a list of tags and comments.</summary>

``` 
$ git tag -n
```

</details>



</details>


<details>
<summary>Delete tag</summary>

``` 
$ git tag -d < tagname >
```

</details>


## Chapter 8 : Aliases
__Which greatly reduce the amount of typing you have to do.__
<details>
<summary>Create alias</sumamary>

```
$ git config --global alias.<alias-name> '<git-command>'
```

> '<git-command>' Git command that you want to minify to alias.

</details>

<details>
<summary>Create the st alias</summary>

```
$git config --global alias.st status
``` 

</detail>

</details>

<details>
<summary>Create a branch and 
check it out</summary>

```
$git config --global alias.bc checkout -b 
$git config --global alias.cb checkout -b 
``` 

> The important thing to notice here is that your alias can take one or more flags. 

</detail>

</details>

<details>
<summary>A lot commits everything and waits for a message</summary>

```
$git config --global alias.cam commit -a -m
``` 

</detail>

<details>
<summary>Commits everything along with the message you give it</summary>

```
$git cam  "Here is you message"
``` 

</detail>


<details>
<summary>Offers me an alternative to log --oneline that gives much more information</summary>

```
$git config –global alias.lg log --graph --pretty=format:'%Cred%h%Creset 
-%C(yellow)%d%Creset %s %Cgreen(%cr) %C(yellow)<%an>%Creset' --abbrev-commit
``` 

</detail>


<details>
<summary>Opens the global configuration file in your editor</summary>

```
$git config --edit --global
``` 

- Note :
>  You can add aliases directly here if you like.

</detail>

