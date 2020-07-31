## Task description ##

Develop a [FindNthRoot](MethodNewtonTask/NumbersExtension.cs#L30) method that implements an algorithm of the [Newton method](https://en.wikipedia.org/wiki/Nth_root_algorithm) to calculate approximation $`\sqrt[n]{a}`$, where `n > 0`- an integer, `a`- a real number (`System.Double`), `(0; ε), 0 < ε < 1`- a given accuracy, `ε`- a real number (`System.Double`). The value of the `ε`-epsilon constant is set in the [configuration file](MethodNewtonTask.Tests/AppSettings.json).

As the found value $`\sqrt[n]{a}`$ use such a value of $`x_k`$ at which $`|x_k-x_{k-1}|<ε`$, $`x_{k} = 1/n((n-1)x_{k-1}+a/x_{k-1}^{n-1}), k=1,2,..., x_0=a`$.   

*Topics -  loops with an unknown number of iterations, struct System.Double, equality for System.Double, iterative algorithms.*