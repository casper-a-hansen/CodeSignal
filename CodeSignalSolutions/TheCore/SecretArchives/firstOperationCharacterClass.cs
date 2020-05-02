/*
    Status:   Solved
    Imported: 2020-05-02 13:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/r8LM3RsxeGFXpr8Bj

    Description:
        Given a string which represents a valid arithmetic expression, find the index of
        the character in the given expression corresponding to the arithmetic operation
        which needs to be computed first.
        Note that several operations of the same type with equal priority are computed
        from left to right.
        See the explanation of the third example for more details about the operations
        priority in this problem.
        Example
        For expr = "(2 + 2) * 2", the output should be
        firstOperationCharacter(expr) = 3.
        There are two operations in the expression: + and *. The result of + should be
        computed first, since it is enclosed in parentheses. Thus, the output is the
        index of the '+' sign, which is 3.
        For expr = "2 + 2 * 2", the output should be
        firstOperationCharacter(expr) = 6.
        There are two operations in the given expression: + and *. Since there are no
        parentheses, * should be computed first as it has higher priority. The answer is
        the position of '*', which is 6.
        For expr = "((2 + 2) * 2) * 3 + (2 + (2 * 2))", the output should be
        firstOperationCharacter(expr) = 28.
        There are two operations which are enclosed in two parentheses: + at the
        position 4, and * at the position 28. Since * has higher priority than +, the
        answer is 28.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string expr
        A string consisting of digits, parentheses, addition and multiplication signs
        (pluses and asterisks). It is guaranteed that there is at least one arithmetic
        sign in it.
        Guaranteed constraints:
        5 ≤ expr.length ≤ 45.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SecretArchives
{
    class firstOperationCharacterClass
    {
        int firstOperationCharacter(string expr) {
            var balance = 0;
            var multiplierBalance = -1;
            var multiplierPos = -1;
            var addBalance = -1;
            var addPos = -1;
            for(var i = 0; i < expr.Length; i++) {
                switch(expr[i]) {
                    case '(':
                        balance++;
                        break;
                    case ')':
                        balance--;
                        break;
                    case '*':
                        if (balance > multiplierBalance) {
                            multiplierBalance = balance;
                            multiplierPos = i;
                        }
                        break;
                    case '+':
                        if (balance > addBalance) {
                            addBalance = balance;
                            addPos = i;
                        }
                        break;
                }
            }
            if (addBalance > multiplierBalance) return addPos;
            return multiplierPos;
        }
    }
}
