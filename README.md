Enhanced aproach of Simple Builder Pattern based on the following scenario: "Build a component that renders webpages. A page might consist of just a single paragraph"

Major Changes:
-HtmlElement: First, constructors were changed to internal to be accessible only with its own.
Then, 'FactoryMethod' implemented to create a Builder right out of the HtmlElement, being static.
-HtmlBuilder: Implementation of implicit operator, and 'Build' method.
