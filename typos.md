# Typos for *Pro ASP.NET Core 7*

This file contains smaller errors that are unlikely to prevent the code examples from working and which I will correct in the next edition of the book. See [this](errata.md) file for mistakes that prevent the code examples from working as expected.

---

**Chapter 4**

On page 60, the command used in listing 4.1 is deprecated. Use this command instead:

    dotnet new list

(Thanks to Abdul W Yousufzai for reporting this problem)

---

One page 61, this sentence refers to the wrong table:

>   As noted in table 4.3, this template creates a project 
with the minimum content required for ASP.NET Core development.

The description of the projects is in Table 4.2.

(Thanks to Sviridov Maksim for reporting this problem)

---

On page 63, this sentence:

>   Enter demo.html in the Name field, click the Add button to create the new file, and replace the contents with the element shown in listing 4.3. 

should be:

> Enter demo.html in the Name field, click the Add button to create the new file, and 
replace the contents with the **elements** shown in listing 4.3. 

(Thanks to Abdul W Yousufzai for reporting this problem)

---

**Chapter 5**

On page 85, this sentence:

>   Notice that I had to make the same change to the result type declared by the GetProducts method because a Product?[] array cannot be used where a Product[] is expected.

should be:

> Notice that I had to make the same change to the result type declared by the GetProducts method because a **Product[]** array cannot be used where a **Product?[]** is expected.

(Thanks to Phil Puglisi for reporting this problem)

---

**Chapter 16**

On page 428, the description of the HttpOnly property should be:

 >This property specifies whether the browser will prevent 
the cookie from being included in HTTP requests sent by 
JavaScript code. This property should be set to **false** for 
projects that use a JavaScript application whose requests 
should be included in the session. The default value is 
true.

(Thanks to Jihed Halimi for reporting this problem)

---

