# PotterKata

Build and run Applciation.

Using postman or something simlar, do a Get request against the API to get a copy of the JSON object you will use to post the number of books you are looking to purchase.

Copy the JSON object from the Get request.

Create a POST request to the same endpoint using the copied JSON object making sure that you update the number of each book you wish to get.

The best price should be returned.

I have setup the project using Mediatr on purpose as you would normally get the data from some sort of datasourece using the Await command on the data calls.  

The pricing response is returned in GBP and Euro due to briefing given.  It states £ and EUR so returning both based on exchange rate of 1.1 from GBP to Euro currently.

Problem Description
Once upon a time there was a series of 5 books about a very English hero called Harry. 
Children all over the world thought he was fantastic, and, of course, so did the publisher. So in a gesture of immense generosity to mankind, (and to increase sales) they set up the following pricing model to take advantage of Harry’s magical powers.
One copy of any of the five books costs £8. If, however, you buy two different books from the series, you get a 5% discount on those two books. If you buy 3 different books, you get a 10% discount. With 4 different books, you get a 20% discount. If you go the whole hog, and buy all 5, you get a huge 25% discount.
Note that if you buy, say, four books, of which 3 are different titles, you get a 10% discount on the 3 that form part of a set, but the fourth book still costs 8 EUR.
Potter mania is sweeping the country and parents of teenagers everywhere are queueing up with shopping baskets overflowing with Potter books. Your mission is to write a piece of code to calculate the price of any conceivable shopping basket, giving as big a discount as possible.

For example, how much does this basket of books cost?
•	2 copies of the first book
•	2 copies of the second book
•	2 copies of the third book
•	1 copy of the fourth book
•	1 copy of the fifth book
