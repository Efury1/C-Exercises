# Bob's Response Task

## Introduction

Bob is a lackadaisical teenager who thinks he's very cool. He doesn't get excited about things, and he definitely doesn't want to respond with enthusiasm. When people talk to him, his responses are limited and depend on how the conversation unfolds.

### Problem Description

You need to write a program that simulates Bob's responses based on certain input conditions. Bob only ever responds with one of five predefined responses based on the input he receives.

## Bob's Possible Responses

Bob's responses are determined by the following rules:

1. **"Sure."**  
   - Bob answers with this if you ask him a question, and the question ends with a question mark (`?`).
   - Example: `"How are you?"` → **"Sure."**

2. **"Whoa, chill out!"**  
   - Bob answers with this if you are yelling at him (ALL CAPITAL LETTERS).
   - Example: `"WATCH OUT!"` → **"Whoa, chill out!"**

3. **"Calm down, I know what I'm doing!"**  
   - Bob answers with this if you yell a question at him (ALL CAPITAL LETTERS followed by a question mark).
   - Example: `"WHAT'S GOING ON?"` → **"Calm down, I know what I'm doing!"**

4. **"Fine. Be that way!"**  
   - Bob answers with this if you are silent or only send whitespace characters (no words).
   - Example: `""` (empty input) → **"Fine. Be that way!"**

5. **"Whatever."**  
   - Bob answers with this for all other input, including statements and anything else.
   - Example: `"Hello!"` → **"Whatever."**

---

## Instructions

### Task

Your task is to write a function or method that will take an input string, and return one of Bob's responses based on the rules above.

### Input Format

- The input is a string that could contain any text.
- The string may include spaces, punctuation, and a mix of uppercase and lowercase letters.

### Output Format

- The output should be one of Bob’s predefined responses:
  - "Sure."
  - "Whoa, chill out!"
  - "Calm down, I know what I'm doing!"
  - "Fine. Be that way!"
  - "Whatever."

---

## Example Scenarios

### Example 1

**Input**: `"How are you?"`  
**Output**: `"Sure."`

### Example 2

**Input**: `"WATCH OUT!"`  
**Output**: `"Whoa, chill out!"`

### Example 3

**Input**: `"WHAT'S GOING ON?"`  
**Output**: `"Calm down, I know what I'm doing!"`

### Example 4

**Input**: `""`  
**Output**: `"Fine. Be that way!"`

### Example 5

**Input**: `"Hello!"`  
**Output**: `"Whatever."`

---

## How to Debug

If you encounter issues while implementing Bob's responses, here are a few debugging steps you can follow:

1. **Check the Input Type**  
   - Ensure that the input is a string.
   - Test edge cases like empty strings, strings with only spaces, or strings with special characters.

2. **Check for Question Mark**  
   - Ensure that the input correctly detects whether the string ends with a question mark (`?`), which is necessary to return "Sure." or "Calm down, I know what I'm doing!".

3. **Check for All Capital Letters**  
   - Bob yells back at you if the string is in **ALL CAPS** (uppercase). Ensure that the logic correctly identifies this condition.
   - Example: `"HELLO"` should return `"Whoa, chill out!"`.

4. **Check for Empty or Whitespace-only Input**  
   - Bob responds with "Fine. Be that way!" if there is no content or just whitespace in the input. Make sure your program handles this edge case properly.

5. **Check for Other Statements**  
   - If the input doesn't meet any of the previous criteria, Bob should respond with "Whatever.". Ensure your default case works correctly.

---

## Testing the Program

To test the program, you can use the following example cases:

- Test with regular questions: `"Is it raining?"`
- Test with yelling: `"I CAN'T FIND MY KEYS!"`
- Test with silence: `""` (empty string)
- Test with mixed characters: `"Hello, World!"`

Ensure your program passes all these tests and returns the correct response for each case.

---

## Conclusion

Bob is a simple character with very specific rules for how he responds to people. With the conditions outlined in this task, you can implement a function to simulate Bob’s interactions in a fun and straightforward way.

---
