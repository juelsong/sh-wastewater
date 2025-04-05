using Furion.JsonSerialization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ESys.Swagger
{
    public class EnumSchemaFilter : ISchemaFilter
    {
        /// <summary>
        /// JSON ���л�
        /// </summary>
        private readonly IJsonSerializerProvider _serializerProvider;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="serializerProvider"></param>
        public EnumSchemaFilter(IJsonSerializerProvider serializerProvider)
        {
            _serializerProvider = serializerProvider;
        }

        /// <summary>
        /// ʵ�ֹ���������
        /// </summary>
        /// <param name="model"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiSchema model, SchemaFilterContext context)
        {
            var type = context.Type;

            // �ų��������򼯵�ö��
            if (type.IsEnum && Furion.App.Assemblies.Contains(type.Assembly))
            {
                model.Enum.Clear();
                var stringBuilder = new StringBuilder();
                stringBuilder.Append($"{model.Description}<br />");

                var enumValues = Enum.GetValues(type);
                foreach (var value in enumValues)
                {
                    // ��ȡö�ٳ�Ա����
                    var fieldinfo = type.GetField(Enum.GetName(type, value));
                    var descriptionAttribute = fieldinfo.GetCustomAttribute<DescriptionAttribute>(true);
                    model.Enum.Add(OpenApiAnyFactory.CreateFromJson(_serializerProvider.Serialize(value)));

                    stringBuilder.Append($"&nbsp;{descriptionAttribute?.Description} {value} = {value}<br />");
                }
                model.Description = stringBuilder.ToString();
            }
        }
    }
}