# AWright18.PipeTo  

## What does it do? 
PipeTo was created to allow you to pipe the results of a method call or function call to another method or function call.  It was Inspired by the F# forward pipe operator that looks like this |>. 

Here is a simple example of something you might do with PipeTo. 

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

## [How to use it](https://awright18.github.io/AWright18.PipeTo/examples.html)

## [How to install it](https://awright18.github.io/AWright18.PipeTo/install.html)

## [How to build it](https://awright18.github.io/AWright18.PipeTo/build.html)







