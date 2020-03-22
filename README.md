# solid-examples
Examples includes explaintation for each principle
# Single Responsibility Principle
Given that we have an class called Employee with two methods CalculateSalary and Output. What if we use this class for other application which just needs the CalculateSalary method? Yes, the Output method might not used. This design violates Single Responsibility Principle. Because the Employee class has two responsibilities. This would lead to some trouble for the application above. If the Output use some GUI library, it will take much time to compile, link to device ...
<b>Solution:</b> For better design, we should create a new separated class named EmployeeForCalculator. So that, if there is any change in the way we calculate, we do not need to change the original Employee class.
# Open - closed Principle

# Liskov Subsitution Principle

# Interface Segration Principle

# Dependency Inversion Principle
