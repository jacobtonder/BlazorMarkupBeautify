[![.NET](https://github.com/jacobtonder/BlazorMarkupBeautify/actions/workflows/dotnet.yml/badge.svg)](https://github.com/jacobtonder/BlazorMarkupBeautify/actions/workflows/dotnet.yml)
[![Nuget](https://img.shields.io/nuget/v/BlazorMarkupBeautify)](https://www.nuget.org/packages/BlazorMarkupBeautify/)
![last commit](https://img.shields.io/github/last-commit/jacobtonder/BlazorMarkupBeautify)

# BlazorMarkupBeautify

BlazorMarkupBeautify is a .NET library intended to enable developers use control structures through markup instead of conspicuous C# code in their Blazor applications.  

## Purpose

The purpose of this library is to enable developers use markup instead of C# when using control structures. This should help increase readability of the code, instead of having to switch between html and C#.

Currently, this library supports conditional and iteration.

## Installation

Install this package through NuGet Packages in Visual Studio or through command line. Alternatively, you can download the latest release [here](https://github.com/jacobtonder/BlazorMarkupBeautify/releases).

Tip: Since you most likely will be using this on all your Razor pages, you can include this line in "_Imports.razor"

```csharp
@using BlazorMarkupBeautify
```

## Conditionals

Conditional statements are used to execute one or more statements if a condition is met.

An example in current Blazor can be seen below:

```html
@if (condition)
{
  <p>Condition evaluated to true.</p>
}
else 
{
  <p>Condition evaluated to false.</p>
}
```

This mixes both C# and HTML, which may be confusing to the reader.

Instead, using this library, the code can be rewritten with almost pure HTML as seen in the example below:

```html
<Conditional Condition=@condition>
  <True>
    <p>Condition evaluated to true.</p>
  </True>
  <False>
    <p>Condition evaluated to false.</p>
  </False>
</Conditional>
```

## Iteration

Iteration serves the purpose of repeating a statement a certain number of times.

An example in current Blazor can be seen below:

```html
@foreach(var number in @Enumerable.Range(0, 10))
{
  <p>@number</p>
}
```

Once again, using this library, the code can be rewritten with almost pure HTML as seen in the example below:

```html
<ForEach Collection=@Enumerable.Range(0, 10)>
  <p>@context</p>
</ForEach>
```

The collection parameter can be set to any enumerable.

## Fizz Buzz

To show a more complex example, below is a naive implementation of Fizz Buzz using this library:

```html
<ForEach Collection=@Enumerable.Range(1, 100)>
  <p>
    <Conditional Condition=@(context % 3 == 0)>
      <True>Fizz</True>
    </Conditional>
    <Conditional Condition=@(context % 5 == 0)>
      <True>Buzz</True>
    </Conditional>
    <Conditional Condition=@(context % 3 != 0 && context % 5 != 0)>
      <True>@context</True>
    </Conditional>
  </p>
</ForEach>
```
