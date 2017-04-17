using System;
using System.Linq;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor
{
    public static class XsdParticleExtensions
    {
        public static bool IsSequence(this XsdParticle root, Path path, int min, int max)
        {
            return IsGroup(root, path, ParticleGroupType.Sequence, min, max);
        }

        public static bool IsChoice(this XsdParticle root, Path path, int min, int max)
        {
            return IsGroup(root, path, ParticleGroupType.Choice, min, max);
        }

        public static bool IsGroup(this XsdParticle root, Path path, ParticleGroupType type, int min, int max)
        {
            bool ret = false;

            XsdParticleGroup group = root as XsdParticleGroup;
            if (@group != null)
            {
                if (path.IsEmpty())
                {
                    ret = (@group.GroupType == type) && (@group.MinOccurs == min) && (@group.MaxOccurs == max);
                }
                else if (path.Head() < @group.Items.Count)
                {
                    ret = IsGroup(@group.Items[path.Head()], path.Tail(), type, min, max);
                }
            }
            return ret;
        }

        public static bool AllItemsAreElements(this XsdParticle root, Path path)
        {
            bool ret = false;

            XsdParticleGroup group = Get(root, path) as XsdParticleGroup;
            if (@group != null)
            {
                ret = @group.Items.All(x => x is XsdParticleElement);
            }
            return ret;
        }

        public static int CountItems(this XsdParticle root, Path path)
        {
            int ret = 0;

            XsdParticleGroup group = Get(root, path) as XsdParticleGroup;
            if (@group != null)
            {
                ret = @group.Items.Count;
            }
            return ret;
        }

        public static bool IsElement(this XsdParticle root, Path path)
        {
            return Get(root, path) is XsdParticleElement;
        }

        public static bool TestAllItems(this XsdParticle root, Path path, Func<Path, bool> test)
        {
            bool ret = false;

            XsdParticleGroup group = Get(root, path) as XsdParticleGroup;
            if (@group != null)
            {
                ret = true;
                int i = 0;
                while ((i < @group.Items.Count) && ret)
                {
                    if (!test(path.Sub(i)))
                    {
                        ret = false;
                    }
                    i++;
                }
            }
            return ret;
        }

        public static bool TestAllItems_2(this XsdParticle root, Path path, Func<Path, bool> test)
        {
            XsdParticleGroup group = Get(root, path) as XsdParticleGroup;
            if (@group == null)
            {
                return false;
            }

            for (int i = 0; i < @group.Items.Count; i++)
            {
                if (!test(path.Sub(i)))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AllItemsAreElementOrChoiceOfElements(this XsdParticle root, Path path)
        {
            return TestAllItems(root, path, subpath =>
            {
                return IsElement(root, subpath)
                       || ((IsChoice(root, subpath, 0, int.MaxValue) || IsChoice(root, subpath, 1, int.MaxValue))
                           && AllItemsAreElements(root, subpath));
            });
        }

        public static XsdParticle Get(this XsdParticle root, Path path)
        {
            XsdParticle found = null;

            if (path.IsEmpty())
            {
                found = root;
            }
            else
            {
                XsdParticleGroup group = root as XsdParticleGroup;
                if (@group != null)
                {
                    if (path.Head() < @group.Items.Count)
                    {
                        found = Get(@group.Items[path.Head()], path.Tail());
                    }
                }
            }
            return found;
        }

        public static string SafeOccursToString(this XsdParticle root)
        {
            return SafeOccursToString(root.MinOccurs, root.MaxOccurs);
        }

        public static string SafeOccursToString(int minOccurs, int maxOccurs)
        {
            if (maxOccurs == int.MaxValue)
            {
                return "[" + minOccurs + ", *]";
            }
            return "[" + minOccurs + ", " + maxOccurs + "]";
        }
    }
}