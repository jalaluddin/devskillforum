using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IVotable 
{
	int UpVoteCount { get;set; }

	int DownVoteCount { get;set; }

	void IncreaseUpVote();

	void IncreaseDownVote();

}

