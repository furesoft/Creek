using System.Linq;
using System.Text;
using Creek.Database.Api.Query;

namespace Creek.Database.Core.Query.Criteria
{
    internal sealed class Or : ComposedExpression
    {
        public Or(IQuery query) : base(query)
        {
        }

        public override bool Match(object @object)
        {
            return Constraints.Any(constraint => ((IInternalConstraint)constraint).Match(@object));
        }

        public override string ToString()
        {
            var buffer = new StringBuilder();
            
            buffer.Append("(");
            var isFirst = true;

            foreach (var constraint in Constraints)
            {
                if (isFirst)
                {
                    buffer.Append(constraint);
                    isFirst = false;
                }
                else
                {
                    buffer.Append(" or ").Append(constraint);
                }
            }

            buffer.Append(")");
            return buffer.ToString();
        }
    }
}
