# Process Commands
Every RED/RES tab has a command to invoke some process on RES.

These commands do not need to perform any logic themselves.  They are used as a formal configuration definition.

## Actions
Process Action commands are used when the RES called does not return data.

## Functions
Process Function commands are used when the RES call does return data.  As such, they require additional configuration on how to redirect the data returned.

This is defined in the parameter of the form: 

```Action<T> onComplete```