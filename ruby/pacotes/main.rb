require 'httparty'

response = HTTParty.get('https://api.github.com')
puts response.body