# Examples - How to use AWright18.PipeTo

### NOTE: All of the following examples will print "Hello from AWright18.PipeTo" to the console. 

### A value piped to a System.Action that takes one argument

```csharp 

    "Hello From AWright18.PipeTo".PipeTo(Console.WriteLine);

```

### A value piped to an System.Action that takes two arguments

```csharp

    "Hello From {0}".PipeTo(Console.WriteLine,"AWright18.PipeTo");

```

### A value piped to a System.Func that takes one argument and returns another argument

```csharp 

    var helloWorld = "Hello From AWright18.PipeTo".PipeTo((s) => s);

    helloWorld.PipeTo(Console.WriteLine);
``` 

### A value piped to a System.Func that takes two arguments and returns another argument

```csharp

    var helloWorld = "Hello From {0}".PipeTo(string.Format,"AWright18.PipeTo");

    helloWorld.PipeTo(Console.WriteLine);

```


### Creating a pipe line of multiple functions.

```csharp

        static void Main(string[] args)
        {
            "Hello"
                .PipeTo(AddFrom)
                .PipeTo(AddWho, "Awright18.PipeTo")
                .PipeTo(Console.WriteLine);
        }

        static string AddFrom(string s)
        {
            return s + " from";
        }

        static string AddWho(string s, string who)
        {
            return s + " " + who;
        }

```

### Alternatively of course you can use lambda expressions 

```csharp 
    static void Main(string[] args)
    {
        "Hello"
            .PipeTo((value) => value + " from")
            .PipeTo((value,who) => value + " " + who,"AWright18.PipeTo")              
            .PipeTo(Console.WriteLine);
    }
```