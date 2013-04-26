using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem11 {
        public int getLargestProductIn (int[][] grid) {
            return Enumerable.Range(0, 16).Select(r =>
                Enumerable.Range(0, 16).Select(c => {
                    var grid4x4 = new int[][] {
                        new int [] { grid[r + 0][c + 0], grid[r + 0][c + 1], grid[r + 0][c + 2], grid[r + 0][c + 3], },
                        new int [] { grid[r + 1][c + 0], grid[r + 1][c + 1], grid[r + 1][c + 2], grid[r + 1][c + 3], },
                        new int [] { grid[r + 2][c + 0], grid[r + 2][c + 1], grid[r + 2][c + 2], grid[r + 2][c + 3], },
                        new int [] { grid[r + 3][c + 0], grid[r + 3][c + 1], grid[r + 3][c + 2], grid[r + 3][c + 3], },
                    };

                    var products = new List<int>();
                    Func<int, int, int> multiplication = (x, y) => x * y;

                    // 4 rows across
                    products.AddRange(
                        Enumerable.Range(0, 4).Select(row =>
                            grid4x4[row].Aggregate(multiplication)
                        )
                    );

                    // 4 rows down
                    products.AddRange(
                        Enumerable.Range(0, 4).Select(col =>
                            Enumerable.Range(0, 4).Select(row =>
                                grid4x4[row][col]
                            ).Aggregate(multiplication)
                        )
                    );

                    // top-left to bottom-right diagonal
                    products.Add(
                        Enumerable.Range(0, 4).Select(rowCol =>
                            grid4x4[rowCol][rowCol]
                        ).Aggregate(multiplication)
                    );

                    // bottom-left to top-right diagonal
                    products.Add(
                        Enumerable.Range(0, 4).Reverse().Select(row => {
                            // col is always the absolute value of row minus 3, 
                            // it increases as row decreases
                            return grid4x4[row][Math.Abs(row - 3)];
                        }).Aggregate(multiplication)
                    );

                    return products.Max();
                })
            ).SelectMany(x => x).Max();
        }
    }
}
