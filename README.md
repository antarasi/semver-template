# semver-template
Place SEMVER parts in file template

## Usage

```
st.exe 4.2.10 .\template.txt .\output.txt
```

### template.txt
```
test semver
second row
semver: ${MAJOR}.${MINOR}.${PATCH}
last row
patch: ${PATCH}, minor: ${MINOR}, major: ${MAJOR}
```

### output.txt
```
test semver
second row
semver: 4.2.10
last row
patch: 10, minor: 2, major: 4
```


## License
MIT
