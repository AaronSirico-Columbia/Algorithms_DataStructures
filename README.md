# Algorithms_DataStructures
## Explanation of Each Data Structure
1. Array
 - How does am Array work?
    - An array in c# is a fixed set of elements of the same data type. Each element is stored in an adjacent memory place and is accessed by an index.
 - How are they different from each other?
    - An array adds values to their collections sequentially unlike a stack or a queue. An array's overall size can not be changed unlike a dictionary. Values can not be added to an array if the size of the array is fulfilled. Also an array accesses its values
      through an index. A dicitionary uses a key in which can be defined by the programmer, unlike an index which is always of type int.
 - When is one more efficient than another?
    - An array is more efficient than a dictionary because it costs less memory. Also an array is always in constant time O(1). Most of the time a dictionary can be O(1) but the worst case it could possibly execute in O(n). Stacks and Queues are used in very specific cases
      and at times are not compared to an array. An array is more effcient when the task is not specific and needs a general collection.
      
2. Dictionary
 - How does a Dictionary work?
    - A dicitionary in c# is a collection of key value pairs. Each key is unique and has a matching value attatched to it. Dictionaries thrive off of their key value pairs.
 - How are they different from each other?
    - A dictionary can add as many key value paris as it'd like. Compared to an array which can not. Also a dicitonary adds its elements sequentially unlike a stack or a queue.
 - When is one more efficient than another?
    - A main advantage of using a dictinary is that it's overall size can change. This is when it is more effcient than an array. Although dictionaries take more space, they can be more effcient in the long run if your data collection is going to be fluctuating in size.
    - 
3. Stack
 - How does a Stack work?
    - A stakc in c# is a data structure that uses Last in First out method. This means that the last item pushed onto the stack is the first one to be popped off.
 - How are they different from each other?
    - A stack uses LIFO to add values to it's collection. This differs from a dictionary and an array. A queue however uses a simliar method but is FIFO. 
 - When is one more efficient than another?
    - The difference between a stack and a queue are very sitautional based. Some problems that stacks solve better than queues are: reversing the order of a collection, dealing with recursive algorithms, or resource management. Resource managment dealing with temporary
      varaibles and allocating memory.
      
4. Queue
 - How does a Queue work?
    - A queue in c# is a data structure that follows the first in first out principle. This means that the first item added to the queue is the first one to be removed. 
 - How are they different from each other?
    - A Queue uses a FIFO to add values to it's collection. Dictionaries and arrays do no add values to their collections like that.
 - When is one more efficient than another?
    - As stated above, a queue will excel above a stack in very situational times. Certain situations such as: message queues because a queue can ensure the message is handled based on its arrival time, and task scheduling due to tasks being processed in the order they were
      enqeued.
