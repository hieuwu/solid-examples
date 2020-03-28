# solid-examples
Examples includes explaintation for each principle
# Single Responsibility Principle
SRP states: <b>"THERE SHOULD NEVER BE MORE THAN ONE REASON FOR A CLASS TO CHANGE"</b><br>
Given that we have an class called Employee with two methods CalculateSalary and Output. What if we use this class for other application which just needs the CalculateSalary method? Yes, the Output method might not used. This design violates Single Responsibility Principle. Because the Employee class has two responsibilities. This would lead to some trouble for the application above. If the Output use some GUI library, it will take much time to compile, link to device ...
For better design, we should create a new separated class named EmployeeForCalculator. So that, if there is any change in the way we calculate, we do not need to change the original Employee class. Do the same with Output method.
<a href="https://imgur.com/IK0m53J"><img src="https://i.imgur.com/IK0m53J.jpg" title="source: imgur.com" /></a>
# Open - closed Principle
OP states: <b>"SOFTWARE ENTITIES (CLASSES, MODULES, FUNCTIONS, ETC.) SHOULD BE OPEN FOR EXTENSION, BUT CLOSED FOR MODIFICATION"</b><br>
Given that at the first time, our company just has two type of employee is Manager and Director, we need a method CalculateAllSalaries. Each position has different way to calculate the salary. So for each position, we create a method CalculateSalary. What if when the company expands, more position with different salary and the number of employee is bigger? Yes, we have to add more if/else/switch-case block in CalculateAllSalaries method and new calculate method whenever we have additional postions like Designer or Developer. This violates Open-closed Principle.
In order to fix this, we can add more class for each new position, inherit the Employee class. Then we can override CalculateSalary method for each class separately. If we need to add more type, just add a new job title then do the same as above.
<a href="https://imgur.com/GLLjn1C"><img src="https://i.imgur.com/GLLjn1C.jpg" title="source: imgur.com" /></a>
# Liskov Subsitution Principle
LSP states: <b>"FUNCTIONS THAT USE POINTERS OR REFERENCES TO BASE CLASSES MUST BE ABLE TO USE OBJECTS OF DERIVED CLASSES WITHOUT KNOWING IT".</b><br>
Given that we have a Rectangle class. For the first time when we learn OOP concept, we misunderstand that when we add a Square, then Square should inherits Rectangle. Follow IS-A relation, this type of inheritants is quite good. However, this is wrong. Let's make it clear. Rectangle has Width and Height properties, follow them are SetHeight(), GetHeight(), SetWidth(), GetWidth(). Does a Square class need the Height property and the Get/Set for it? What if we create 1.000.000 objects in Square type? Wastful!. Ignore the memory, for Get/Set of Width and Height, in each method, we can assign Width = Height and reverse this assignment.<br>
<a href="https://imgur.com/y7CYt4G"><img src="https://i.imgur.com/y7CYt4G.jpg" title="source: imgur.com" /></a>
# Interface Segration Principle
ISP states: <b>"A CLIENT SHOULD NEVER BE FORCED TO IMPLEMENT AN INTERFACE THAT IT DOESN'T USE OR CLIENTS SHOULDN'T BE FORCED TO DEPEND ON METHODS THEY DO NOT USE"</b> <br>
Given that we have a Dog class. And a interface DogBehavior includes all of the action of a dog like Bark(), Eat(), Sleep(), Play(), Sing(). In a case that the dog in the Circus, it just needs the Sing() method. Does we have to implement the whole DogBehavior interface? No, we should divide the big interface into smaller one for each role of a object. For example, in the circus, Dog just need to implement a interface named DogInCircus to perform some certain actions.
<a href="https://imgur.com/xRlVNsR"><img src="https://i.imgur.com/xRlVNsR.jpg" title="source: imgur.com" /></a>
# Dependency Inversion Principle
DIP states: <b>"A. HIGH LEVEL MODULES SHOULD NOT DEPEND UPON LOW
LEVEL MODULES. BOTH SHOULD DEPEND UPON ABSTRACTIONS. <br>
B. ABSTRACTIONS SHOULD NOT DEPEND UPON DETAILS. DETAILS
SHOULD DEPEND UPON ABSTRACTIONS"</b><br>
Given that we have scenario on motobike that when we use the HandBrake, the BackLight is turned on. Then we have a relationship between HandBrake and BackLight class. The HandBrake sends TurnOn() message to BackLight so HandBrake holds an instance of BackLight class. This depency implies that the HandBrake must be changed whenever the BackLight class changes. This design violates DIP because a high level module depends on a low level one. To conform DIP, we need to isolate the details depend upon abstractions. First, we declare two absract classes named HandBrakeClient and HandBrake, these two classes has a contain relationship. Then, the HandBrakeImplementation would inherit from HandBrake, and BackLight would inherit from HandBrakeClient. Now, the HandBrake class knows nothing about the BackLight. This is because of the isolation with in two concrete derivatives: HandBrakeImplementation and BackLight.<br>
This style of design help us reuse any kind of HandBrake. It is not affected by changes to the low level of implementation.
<a href="https://imgur.com/wfM0TKq"><img src="https://i.imgur.com/wfM0TKq.jpg" title="source: imgur.com" /></a>
