
import { toPoll, PollAdapter} from "@/adapters/poll-adapter"
import { Poll, CreatePoll, AddVoteModel } from '@/models/poll-model'

export async function getAllPolls(): Promise<Poll[]> {
    const response = await fetch('${API_URL}/polls');

    const data = (await response.json()) as PollAdapter[];

    const polls = data.map(po => toPoll(po));

    return polls;
    
}

export async function createPoll(createModel: CreatePoll): Promise<string>
{
    await fetch('${API_URL}/polls'), {
        headers: {
            "Content-Type": "application/json"
        },
        method: "POST",
        body: JSON.stringify(createModel)
    }

    return "Create Movie Successfully"
}

export async function addVote(payload: AddVoteModel): Promise<string>
{
    await fetch('${API_URL}/polls/${payload.id}/votes'), {
        headers: {
            "Content-Type": "application/json"
        },

        method: "POST",
        body: JSON.stringify({
            value: payload.value
        })
    }

    return "Added vote successfully"
}