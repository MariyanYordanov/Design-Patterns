# Design-Patterns
Cheetsheets 

## Factory Pattern
The Factory Pattern - also known as the Factory Method pattern and the Abstract Factory pattern - is typically used when you want to create instances of objects with specific configurations or default values, especially when you have a hierarchy of objects.

You can use the Factory Pattern to create test objects with consistent default values or configurations. It’s useful when you have a complex object creation process, and you want to encapsulate that complexity.

In unit testing, you might use a factory to create mock objects, stubs, or instances of your classes for testing. For instance, you could create a ProductFactory that generates product objects with different categories and prices for testing.

## Object Mother Pattern
The Object Mother Pattern is used when you want to create and configure a group of objects with specific attributes or states to be used consistently across multiple test cases. It’s suitable for scenarios where you need predefined test data. The Object Mother pattern does allow for some customizations, through multiple Create options.

Object Mothers are useful for setting up a consistent test environment by providing pre-configured objects or object graphs with various states. This pattern is often used in integration or system testing.

In integration testing, you might use an OrderObjectMother to create order-related objects with specific data (e.g., customers, products, and orders) to simulate various scenarios during testing.

## Builder Pattern
The Builder Pattern is used when you need to construct complex objects step by step and provide flexibility in configuring their attributes. It’s particularly useful when there are many optional parameters to set.

This is commonly seen with classes with a large amount of customizable parameters. The Builder class has a private variable to hold the base object. Use With... methods to allow for a specific parameter to be set. The Builder has a Build() method to return the object with all of its customizations.

The Builder Pattern is valuable for creating test objects with customizable attributes. It’s especially useful when you need to set a specific combination of properties for your test objects.

In unit testing, you could use a builder to construct instances of a class with various configurations. For instance, you might have a ProductBuilder that allows you to set different product attributes like name, price, and category during object creation.
