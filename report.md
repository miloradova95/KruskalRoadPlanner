# Final Project Report

Course: C# Development SS2025 (4 ECTS, 3 SWS)

Student ID: cc231051

BCC Group: B

Name: Aleksandar Miloradovic

## Methodology: 
First i googled for some websites to explain to me the purpose of the Kruskal Algorithm.
Then I found a very useful YouTube Video (linked in the reference), where a guy explains the algoroithm and gives a hands on example in C#.
Although his example was complex and already nested in an existing project achitecture, it helped me 
grasped the bigger picture of the algorithm.

After that I started very simple. Seperating every class in different files: Edges, Nodes, UnionFind and Kruskal Algorithm.
I had a nice overview and I could run the program. Only after that I noticed that we have to use Polymorphism, Inheritence and Generics.
I refactored the code again to meet the requirements. I created a Connections class that held the 
**from** and **where** property and ulimately passed it onto the Edge class. 

Then I created the IGraphAlgorithm interface. In the interface i created the Method to find the minimum spanning tree.
i could use other methods that different algorithms use aswell and place them here. This way
I ensure usability and flexibility of the code.

I used Generics in the UnionFind Class, the class that held the logic to find connected nodes and combine them into a bigger set.
For the Kruskal Algorithm it is crucial to detect, that nodes that are connected by an edge are not in the same set to avoid cycles.
## Additional Features
Not much, i added some emojis and the consolelogs were arranged in a way so it looks as neat as possible

## Discussion/Conclusion
The biggest challenge was refactoring after I realized we have to use I had a nice 
overview and I could run the program. Only after that I noticed that we have to use 
Polymorphism, Inheritence and Generics.
Especially implementing the UnionFind class and use the Generic types was a challenge since I was not that comfortable with 
that topic. With the help of AI I kind of wrapped my head around it.

## Work with: 
Myself

## Reference:
[Kruskal’s Greedy Algorithm - YouTube Video](https://www.youtube.com/watch?v=O8Uzk0BCcOk&t=454s)

[GeeksforGeeks - Kruskal’s Minimum Spanning Tree (MST) Algorithm](https://www.geeksforgeeks.org/kruskals-minimum-spanning-tree-algorithm-greedy-algo-2/)

[ChatGPT](https://chatgpt.com/)
