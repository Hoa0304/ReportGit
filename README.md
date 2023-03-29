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
<summary>Show history</summary>

```
 $ git log --decorate
```


</details>



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

``` $ git log --decorate
```

</details>

</details>

<details>
<summary>Add Annotated tag</summary>

<details>
<summary>Add tag</summary>

``` $ git tag -a < tagname >
```

</details>

<details>
<summary>Just created a tag and added a comment</summary>

``` $ git tag -am "commit" < tagname >
```

</details>


<details>
<summary>Displays a list of tags and comments.</summary>

``` $ git tag -n
```

</details>



</details>


<details>
<summary>Delete tag</summary>

``` $ git tag -d < tagname >
```

</details>
