using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class Graph
    {
        public List<List<Vertex>> adjList;

        public Graph()
        {
            adjList = new List<List<Vertex>>();
            for(int i=0;i<=25;i++)
            {
                adjList.Add(new List<Vertex>());
            }
        }

        public void initializeVertex(string start)
        {
            foreach(List<Vertex> list in adjList)
            {
                if(list.Count>0)
                {
                    Vertex v = list.First();
                    if(v.name==start)
                    {
                        v.distance = 0;
                        v.parent = null;
                    }
                    else
                    {
                        v.distance = Int32.MaxValue;
                        v.parent = null;
                    }
                }
            }
        }

        public void relax(Vertex u,Vertex v,int weight)
        {
            if(v.distance>u.distance+weight)
            {
                v.distance = u.distance + weight;
                v.parent = u;
            }
        }


        public void  Dijkstra(string start)
        {
            initializeVertex(start);
            List<Vertex> queue = new List<Vertex>();
            List<Vertex> set = new List<Vertex>();
            foreach(List<Vertex> list in adjList)
            {
                if(list.Count>0)
                {
                    Vertex v = list.First();
                    queue.Add(v);
                }
            }
            while(queue.Count>0)
            {
                Vertex vertex = queue[0];
                foreach(Vertex v in queue)
                {
                    if(v.distance<vertex.distance)
                    {
                        vertex = v;
                    }
                }
                queue.Remove(vertex);
                set.Add(vertex);
                int idx = (vertex.name[0]) % 97;
                foreach(Vertex v in adjList[idx])
                {
                    int index = (v.name[0]) % 97;
                    Vertex u = adjList[index][0];
                    relax(vertex, u, u.weight);
                }
            }

        }
        public void AddEdge(string src,string des,int edgeWeight)
        {
            int id1 = src[0] % 'a';
            int id2 = des[0] % 'a';
            bool sourceFound = false;
            bool destinationFound = false;
            foreach (List<Vertex> list in adjList)
            {
                if (list.Count > 0)
                {
                    Vertex v = list.First();
                    if (v.name == src)
                    {
                        sourceFound = true;
                        Vertex temp = new Vertex(des);
                        temp.weight = edgeWeight;
                        list.Add(temp);
                    }
                    if (v.name == des)
                    {
                        destinationFound = true;
                        Vertex temp = new Vertex(src);
                        temp.weight = edgeWeight;
                        list.Add(temp);
                    }
                }
            }
            if(sourceFound=false)
            {
                Vertex sv = new Vertex(src);
                sv.weight = edgeWeight;
                Vertex ds = new Vertex(des);
                ds.weight = edgeWeight;
                adjList[id1].Add(sv);
                adjList[id1].Add(ds);

            }
            if (destinationFound = false)
            {
                Vertex sv = new Vertex(src);
                sv.weight = edgeWeight;
                Vertex ds = new Vertex(des);
                ds.weight = edgeWeight;
                adjList[id2].Add(sv);
                adjList[id2].Add(ds);

            }
        }
    }
}
