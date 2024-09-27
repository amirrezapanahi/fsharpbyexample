# F# by Example

Content and build toolchain for [F# by Example](https://fsharpbyexample.com),
a site that teaches F# via annotated example programs. Heavily inspired from [Go by Example](https://gobyexample.com) by Mark McGranaghan.

### Overview

The F# by Example site is built by extracting code and
comments from source files in `examples` and rendering
them using `templates` into a static `public`
directory. The programs implementing this build process
are in `tools`, along with dependencies specified in
the `go.mod`file.

The built `public` directory can be served by any
static content system. 

### Building

[![test](https://github.com/mmcgrana/gobyexample/actions/workflows/test.yml/badge.svg)](https://github.com/mmcgrana/gobyexample/actions/workflows/test.yml)

To build the site you'll need Go installed. Run:

```console
$ tools/build
```

To build continuously in a loop:

```console
$ tools/build-loop
```

To see the site locally:

```console
$ tools/serve
```

and open `http://127.0.0.1:8000/` in your browser.

### Add new examples

First create a new entry in `examples.txt`

```
...
...
Example
```

Then create a new folder for the example: 

```
$ mkdir example
```

Create a `fsx` file which contains source code for that file and a `sh` file which resembles the output of that script

```
$ touch example.fsx example.sh
```

When you rebuild the app a `hash` file will automatically be created

```
example.hash
```
### Publishing

To upload the site:

```console
$ export AWS_ACCESS_KEY_ID=...
$ export AWS_SECRET_ACCESS_KEY=...
$ tools/upload
```

### FAQ

#### I found a problem with the examples; what do I do?

We're very happy to fix problem reports and accept contributions! Please submit
[an issue](https://github.com/CompositionalIT/fsharpbyexample/issues) or send a Pull Request.
See `CONTRIBUTING.md` for more details.

#### What version of F# is required to run these examples?

TODO

#### I'm getting output in a different order from the example. Is the example wrong?

TODO

#### Why is there `open System` for each example

This is just for the first line of the code snippet to render the "copy" and "run in playground" buttons

