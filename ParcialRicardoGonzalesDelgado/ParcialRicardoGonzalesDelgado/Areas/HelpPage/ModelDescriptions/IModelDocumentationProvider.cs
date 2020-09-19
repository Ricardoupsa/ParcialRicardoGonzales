using System;
using System.Reflection;

namespace ParcialRicardoGonzalesDelgado.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}