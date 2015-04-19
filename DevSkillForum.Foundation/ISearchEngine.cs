using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ISearchEngine 
{
	string SearchText { get;set; }

	ICollection<Post> Search();

}

