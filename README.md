# solid-examples
Examples includes explaintation for each principle
# Single Responsibility Principle
Given that we have an class called Employee with two methods CalculateSalary and Output. What if we use this class for other application which just needs the CalculateSalary method? Yes, the Output method might not used. This design violates Single Responsibility Principle. Because the Employee class has two responsibilities. This would lead to some trouble for the application above. If the Output use some GUI library, it will take much time to compile, link to device ...
For better design, we should create a new separated class named EmployeeForCalculator. So that, if there is any change in the way we calculate, we do not need to change the original Employee class. Do the same with Output method.
# Open - closed Principle
Given that at the first time, our company just has two type of employee is Manager and Director, we need a method CalculateAllSalaries. Each position has different way to calculate the salary. So for each position, we create a method CalculateSalary. What if when the company expands, more position with different salary and the number of employee is bigger? Yes, we have to add more if/else/switch-case block in CalculateAllSalaries method and new calculate method whenever we have additional postions like Designer or Developer. This violates Open-closed Principle.
In order to fix this, we can add more class for each new position, inherit the Employee class. Then we can override CalculateSalary method for each class separately. If we need to add more type, just add a new job title then do the same as above.
# Liskov Subsitution Principle

# Interface Segration Principle

# Dependency Inversion Principle
