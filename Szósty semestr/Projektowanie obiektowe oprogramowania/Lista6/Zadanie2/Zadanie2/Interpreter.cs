using System;
using System.Collections.Generic;


namespace Zadanie2
{
    public class Context
    {
        private Dictionary<string, bool> variables = new Dictionary<string, bool>();

        public bool GetValue(string VariableName)
        {
            if (variables.ContainsKey(VariableName))
                return variables[VariableName];
            else
                throw new ArgumentException("Variable '{0}' has no value", VariableName);
        }

        public void setValue(string VariableName, bool Value)
        {
            if (variables.ContainsKey(VariableName))
                variables.Remove(VariableName);

            variables.Add(VariableName, Value);
        }
    }

    public abstract class AbstractExpression
    {
        public abstract bool Interpret(Context context);
    }

    public class ConstExpression : AbstractExpression
    {
        public string variableName;

        public ConstExpression(string variableName) 
        {
            this.variableName = variableName; 
        }

        public override bool Interpret(Context context)
        {
            return context.GetValue(variableName);
        }
    }

    public class BinaryExpression : AbstractExpression
    {
        public AbstractExpression Left;
        public AbstractExpression Right;
        public string Operator;

        public override bool Interpret(Context context)
        {
            switch (Operator)
            {
                case "or":
                    return this.Left.Interpret(context) || this.Right.Interpret(context);
                case "and":
                    return this.Left.Interpret(context) && this.Right.Interpret(context);
                default:
                    throw new ArgumentException("Unknown operator");
            }
        }
    }

    public class UnaryExpression : AbstractExpression
    {
        public AbstractExpression Expression;
        public string Operator;

        public override bool Interpret(Context context)
        {
            switch (Operator)
            {
                case "not":
                    return !this.Expression.Interpret(context);
                default:
                    throw new ArgumentException("Unknown operator");
            }
        }
    }
}
