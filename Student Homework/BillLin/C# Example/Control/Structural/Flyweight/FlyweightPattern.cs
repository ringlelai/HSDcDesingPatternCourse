using hsdc.dpt.Control.DTO.Structual.Flyweight;
using hsdc.dpt.Control.DTO.Structual.Flyweight.Intf;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Flyweight
{
    public class CodeFactory
    {
        private static CodeFactory singleton;
        private static object syncRoot = new Object();
        private ConcurrentDictionary<string, Code> flyweights = new ConcurrentDictionary<string, Code>();

        private CodeFactory() { }

        public static CodeFactory GetInstance()
        {
            if (singleton == null)
            {
                lock (syncRoot)
                {
                    if (singleton == null)
                        singleton = new CodeFactory();
                }
            }

            return singleton;
        }

        public Code GetCode(string type) 
        {
            Code code = null;
            switch(type)
            {
                case "CITY":
                    code = flyweights.GetOrAdd(type, c => new CachedCode(type));
                    break;
                case "AREA":
                    code = new UncachedCode(type);
                    break;
            }
            return code;
        }
    }
    public class CachedCode : Code
    {
        private Dao.CodeDao dao = new Dao.CodeDao();
        private List<CodeDto> codes;
        public CachedCode(string CodeType)
        {
            this.codes = dao.query(CodeType);
        }

        public List<CodeDto> GetCodeList(string parentValue = "")
        {
            return this.codes;
        }
    }

    public class UncachedCode : Code
    {
        private Dao.CodeDao dao = new Dao.CodeDao();
        private string CodeType = "";
        public UncachedCode(string CodeType)
        {
            this.CodeType = CodeType;
        }
        public List<CodeDto> GetCodeList(string parentValue = "")
        {
            return dao.query(CodeType, parentValue);
        }
    }

}
