
async.exe: Async.cs
	mcs -o:$@ Async.cs
	mono $@ Async.cs tmp/copy
