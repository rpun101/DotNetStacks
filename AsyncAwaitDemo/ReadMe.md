
### Asynchronous Task in csharp ###

Asynchronous, is opposite of synchronous execution of program. Asynchronous method can yield the execution context while waiting response from another source. This will save execution time and improves an application performance. Here, we play with small asynchronous method example. Notice, the regular way of program takes more than 10s, while methods with asynchronous task takes less than a second to execute the almost same path. 

This is very simplistic example of async and wait in csharp. This is very simple project created to convey the idea of async on the go. The [source article](https://www.exceptionnotfound.net/using-async-and-await-in-asp-net-what-do-these-keywords-mean/) demo on MVC pattern, while I display them on console application.

#### Notes ####
+ note use of `async` keyword
+ return type can be `Task<T>` or `Task`
+ `await` keyword where program expects to wait the execution.
+ find more, drawbacks by using asynchronous task on ‘potential issue’ section.


