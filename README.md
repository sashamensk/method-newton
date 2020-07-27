## Task description ##

Implement an algorithm of the [Newton method](https://en.wikipedia.org/wiki/Nth_root_algorithm) to calculate $`\sqrt[n]{a}`$ - the root of the `n-th` degree (`n ∈ N `) from `a`- real number (`System.Double`) with a given accuracy  `(0; epsilon), 0 < epsilon < 1 `. The value of the epsilon constant is set in the configuration file.   

Newton method: $`\sqrt[n]{a}≈x_k`$, where $`k : |x_k-x_{k-1}|<epsilon`$, $`\{x_k\}:x_{k+1} = 1/n((n-1)x_k+a/x_k^{n-1}), k=0,1,..., x_0=a`$.   

*Topics -  loops, struct System.Double, equality for System.Double.*