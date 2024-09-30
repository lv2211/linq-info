# Deferred Execution vs. Immediate Execution in LINQ

LINQ operators or methods are divided into two categories:

1. **Deferred or Lazy operators**: `Select()`, `SelectMany()`, `Where()`, `Take()`, `Skip()`, etc.
2. **Immediate or Greedy operators**: `Count()`, `Average()`, `Min()`, `Max()`, `First()`, `ToArray()`, `ToList()`, etc.

## Deferred Execution

- The execution of a query/operation is delayed until the actual results are needed.
- The actual execution occurs when you iterate over the results, using methods like `ToArray()`, `ToList()`, `FirstOrDefault()`, or in a `for-each` loop.

### When to Use

- Performance optimization
- Lazy loading
- Dynamic query composition
- Querying external data sources
- Chaining operations

## Immediate Execution

- The query is executed as soon as it is defined.
- Triggered by methods like `ToArray()`, `ToList()`, or `FirstOrDefault()`.

### When to Use

- Small data sets
- Debugging
- Database operations
- Predictable performance
