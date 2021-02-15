# LoopTester
which one loop is better for millions rows in C#?


## Test Result

| Loop | First | Second | Third |
| --- | --- | --- | --- |
| **For** | 1051 | 1057 | 1047 |
| **Do While** | 1063 | 1070 | 1036 |
| **While** | 1031 | 1015 | 1021 |
| **Parallel For** | 872 | 654 | 819 |

*All values show as a millisecond.*